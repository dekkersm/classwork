# -*- coding: utf-8 -*-
import datetime
import datetime
import time

import multiprocessing
a = datetime.datetime.now().replace(microsecond=0)
b = datetime.datetime.now().replace(microsecond=0)
timeout = "00:04:00"
start_dt = datetime.datetime.strptime(timeout, '%H:%M:%S')
arr = []
dicti = {"num": 0, "m": "hi"}

def main():
    # for i in range(100, 999, 10):
    #     dicti["num"] = i
    #     arr.append(dicti.copy())
    # print arr
    # import datetime as dt
    # start = "09:30:00"
    # end = "09:31:00"
    # start_dt = dt.datetime.strptime(start, '%H:%M:%S')
    # end_dt = dt.datetime.strptime(end, '%H:%M:%S')
    # diff = (end_dt - start_dt)
    # print diff.seconds/60
    #print multiprocessing.cpu_count()
    t = datetime.datetime.now()
    time.sleep(60)
    d = datetime.datetime.now()
    if time.mktime(t.timetuple()) - time.mktime(d.timetuple()) < 80000:
        print True
    else:
        print False

if __name__ == '__main__':
    main()