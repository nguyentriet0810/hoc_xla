## khai bao thu vien
import cv2
import numpy as np

##doc anh mau tu thu vien 
img = cv2.imread('lena_color.png', cv2.IMREAD_COLOR)

## lay kich thuoc anh
height = len(img[1])
width = len(img[0])

##khai bao 3 bien chua anh red green blue
red = np.zeros((width, height, 3), np.uint8)
green = np.zeros((width, height, 3), np.uint8)
blue = np.zeros((width, height, 3), np.uint8)

## cho cac diem anh ban dau = 0
red[:]=[0,0,0]
green[:]=[0,0,0]
blue[:]=[0,0,0]

##quet anh tach mau
for x in range(width):
    for y in range(height):
        R = img[x, y, 2]
        G = img[x, y, 1]
        B = img[x, y, 0]

        ##gian gia tri mau cho red green blue
        red[x, y, 2] = R
        green[x, y, 1] = G
        blue[x, y, 0] = B

## hien thi hinh
cv2.imshow('Hinh Goc co gai Lena', img)
cv2.imshow('Hinh Red', red)
cv2.imshow('Hinh GREEN', green)
cv2.imshow('Hinh BLUE', blue)

## thoat hinh ban cach nhan phim bat ki
cv2.waitKey(0)

## xoa data
cv2.destroyAllWindows()