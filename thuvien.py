import cv2          #sử dụng thư viện xử lý ảnh OpenCV cho Python
import numpy as np   #Thư viện toán học, đặc biệt là các tính toán ma trận

# Đọc ảnh màu dùng thư viện OpenCV
img = cv2.imread('lena.png.jpeg', cv2.IMREAD_COLOR)

#Hiển thị hình hình dùng thư viện OpenCV
cv2.imshow('Hinh mau RGB goc co gai Lena', img)

#Bấm phím bất kỳ để đóng cửa sổ hiển thị hình
cv2.waitKey(0)

#Giải phóng bộ nhớ đã cấp phát cho các cửa sổ hiện thị hình
cv2.destroyAllWindows()