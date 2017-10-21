# -*- coding: utf-8 -*-
arr = []
dicti = {"num": 0, "m": "hi"}

def main():
    for i in range(100, 999, 10):
        dicti["num"] = i
        arr.append(dicti.copy())
    print arr

if __name__ == '__main__':
    main()