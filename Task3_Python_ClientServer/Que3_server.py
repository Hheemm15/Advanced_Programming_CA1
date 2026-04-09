import socket
import json

server = socket.socket()
server.bind(("localhost", 5000))
server.listen(1)

print("Server started...")

conn, addr = server.accept()
print("Connected to client")

data = conn.recv(1024).decode()
user = json.loads(data)

print("Received Data:")
print(user)

# Generate simple ID
reg_id = "REG" + str(user["name"][:2]).upper()

conn.send(reg_id.encode())

conn.close()