__author__ = 'Cyber-01'
import hashlib
import socket
import multiprocessing


md5 = "EC9C0F7EDCC18A98B1F31853B1813301"
cpu_num = multiprocessing.cpu_count()

my_socket = socket.socket()
my_socket.connect(("127.0.0.1", 5000))


def computeMD5hash(my_string):
    m = hashlib.md5()
    m.update(my_string.encode('utf-8'))
    return m.hexdigest()


def check_md5(start, end):
    print start
    for num in range(start, end+1):
        if computeMD5hash(str(num)) == str(md5):
            print True
            return "True," + str(num)
    print False
    return "False," + str(start)

while True:
    my_socket.send("1")
    data = my_socket.recv(1024)
    if data == "":
        my_socket.close()
    start = int(data)
    end = start + 10000
    answer = check_md5(start, end)
    my_socket.send(str(answer))