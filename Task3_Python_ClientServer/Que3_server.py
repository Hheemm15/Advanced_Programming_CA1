import socket
import sqlite3

HOST = '127.0.0.1'
PORT = 5050

# create database
conn = sqlite3.connect("customers.db")
cursor = conn.cursor()

cursor.execute("""
CREATE TABLE IF NOT EXISTS customers(
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    name TEXT,
    address TEXT,
    pps TEXT,
    license TEXT
)
""")

conn.commit()

server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind((HOST, PORT))
server.listen()

print("Server started. Waiting for connection...")

conn_socket, addr = server.accept()
print("Connected to client:", addr)

data = conn_socket.recv(1024).decode()
name, address, pps, license = data.split(",")

cursor.execute(
    "INSERT INTO customers(name,address,pps,license) VALUES(?,?,?,?)",
    (name, address, pps, license)
)

conn.commit()

registration_number = "REG" + str(cursor.lastrowid)

conn_socket.send(registration_number.encode())

print("Customer registered with ID:", registration_number)

conn_socket.close()
conn.close()