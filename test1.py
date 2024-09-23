##khai bao mat na sobel
sobelx = [[-1,-2,-1],[ 0, 0, 0],[ 1, 2, 1]]
sobely = [[-1, 0, 1],[-2, 0, 2],[-1, 0, 1]]

R00 = 1
R01 = 2
R03 = 3
R10 = 4
R11 = 5
R12 = 6
R20 = 7
R21 = 8
R22 = 9

for a in range(3):
    for b in range(3):
        print(a)