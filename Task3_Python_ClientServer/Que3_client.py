import socket

HOST = '127.0.0.1'
PORT = 5050

client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

client.connect((HOST, PORT))

print("=== EasyDrive Registration ===")

name = input("Enter Name: ")
address = input("Enter Address: ")
pps = input("Enter PPS Number: ")
license = input("Enter Driving License: ")

data = f"{name},{address},{pps},{license}"

client.send(data.encode())

registration = client.recv(1024).decode()

print("Registration Successful!")
print("Your Registration Number:", registration)

client.close()