__author__ = 'Cyber-01'
import hashlib
import socket


md5 = "EC9C0F7EDCC18A98B1F31853B1813301"

my_socket = socket.socket()
my_socket.connect(("127.0.0.1", 5000))


def computeMD5hash(my_string):
    m = hashlib.md5()
    m.update(my_string.encode('utf-8'))
    return m.hexdigest()


def check_md5(start, end):
    for num in range(int(start), int(end)+1):
        if computeMD5hash(str(num)) == str(md5):
            return True
    return False

while True:
    num_range = my_socket.recv(1024)
    start, end = num_range.split(",")
    answer = check_md5(start, end)
    my_socket.send(str(answer))

print check_md5(1000000000, 1000000099)