import socket
import json

client = socket.socket()
client.connect(("localhost", 5000))

name = input("Enter Name: ")
address = input("Enter Address: ")
pps = input("Enter PPS: ")

data = {
    "name": name,
    "address": address,
    "pps": pps
}

client.send(json.dumps(data).encode())

reg_id = client.recv(1024).decode()

print("Registration ID:", reg_id)

client.close()