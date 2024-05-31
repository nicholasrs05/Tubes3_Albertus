import mysql.connector
from mysql.connector import Error
import alay
import random
import os
from PIL import Image

def find_path(folder_path):
    # List to store bytecode of images
    image_paths = []

    # Get all files in the given folder and sort them alphabetically
    files = sorted(os.listdir(folder_path))

    # Iterate through all files in the sorted list
    for filename in files:
        if filename.lower().endswith('.bmp'):
            image_path = folder_path + "/" + filename
            image_paths.append(image_path)
    
    return image_paths

def duplicate_names(names):
    dupe = []
    for name in names:
        for i in range(10):
            dupe.append(name)
    
    return dupe

# print(len(duped))
# for i in range (0, 100, 10):
#     print(duped[i])




# Specify the folder path containing the .bmp images
folder_path = 'test/Real'

# Convert images to path
paths = find_path(folder_path)

print(paths[:100])

# duped = duplicate_names(alay.res)

# connection = mysql.connector.connect (
#     host='localhost',
#     user='root',
#     password='nicholasrs05',
#     database='tubes3_albertus'
# )

# try:
#     if connection.is_connected():
#         print('Connected to MySQL database')
        
#         # Perform database operations
#         cursor = connection.cursor()

#         for i in range (len(paths)):
#             query = "INSERT INTO sidik_jari (berkas_citra, nama) VALUES (%s, %s)"
#             cursor.execute(query, (paths[i], duped[i]))
#             connection.commit()

# except Error as e:
#     print("Error while connecting to MySQL", e)