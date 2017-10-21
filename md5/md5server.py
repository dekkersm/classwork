# -*- coding: utf-8 -*-
import socket

arr = []
block = {"num": 0, "client": "", "time": "", "finished": False}
server_socket = socket.socket()
server_socket.bind(('0.0.0.0', 5000))

server_socket.listen(1)

(client_socket, client_address) = server_socket.accept()


def main():
    while True:
        for i in range(1000000000, 9999999999, 10000):
            block["num"] = i
            arr.append(block.copy())
        client_socket.send("1000000000,1000000099")
        client_msg = client_socket.recv(1024)
        print client_msg

if __name__ == '__main__':
    main()