# -*- coding: utf-8 -*-
import socket
import select
import datetime, time

arr = []
block = {"num": 0, "client": "", "time": "", "finished": False}
server_socket = socket.socket()
server_socket.bind(('0.0.0.0', 5000))

server_socket.listen(1)

open_clients = []
messages_to_send = []

for i in range(1000000000, 9999999999, 10000):  # dividing the range into blocks
    block["num"] = str(i)
    arr.append(block.copy())


def send_waiting_messages(wlist):
    for message in messages_to_send:
        (client_socket, data) = message
        if client_socket in wlist:
            client_socket.send(data)
            messages_to_send.remove(message)


def main():
    while True:
        rlist, wlist, xlist = select.select([server_socket] + open_clients, open_clients, [])
        for current_socket in rlist:
            if current_socket is server_socket:
                (new_socket, address) = server_socket.accept()
                open_clients.append(new_socket)
            else:
                data = current_socket.recv(1024)
                print data
                if data == "":
                    open_clients.remove(current_socket)
                elif data.isdigit():  # if client sends num of cores
                    #send block
                    for block in arr:
                        block["num"]
                        if not block["finished"]:
                            if block["time"] == "":
                                block["client"] = current_socket
                                block["time"] = int(time.mktime(datetime.datetime.now().timetuple()))
                                messages_to_send.append((current_socket, block["num"]))
                                break
                            if time.mktime(datetime.datetime.now().timetuple()) - block["time"] > 30000:
                                block["client"].close()
                                open_clients.remove(block["client"])
                                block["client"] = current_socket
                                block["time"] = int(time.mktime(datetime.datetime.now().timetuple()))
                                messages_to_send.append((current_socket, block["num"]))
                                break
                else:
                    answer, num = data.split(",")  # if client sends an answer
                    bool(answer)
                    if answer == True:
                        print num
                        for sock in open_clients:
                            sock.close()
                    elif answer == False:
                        indx = arr.index(filter(lambda n: n.get('num') == num, arr)[0])
                        arr[indx]["finished"] = True
        send_waiting_messages(wlist)

if __name__ == '__main__':
    main()