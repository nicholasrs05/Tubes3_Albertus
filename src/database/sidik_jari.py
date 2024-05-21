import mysql.connector
from mysql.connector import Error
import alay
import random
import os
from PIL import Image

def bytecode_to_binary(bytecode):
    # Convert each byte to its binary representation and join them
    binary_representation = ''.join(f'{byte:08b}' for byte in bytecode)
    return binary_representation

def binary_string_to_ascii(binary_string):
    # Split the binary string into 8-bit segments and convert to ASCII
    ascii_representation = ''.join(chr(int(binary_string[i:i+8], 2)) for i in range(0, len(binary_string), 8))
    return ascii_representation
# print(binary_string_to_ascii("0100100001100101011011000110110001101111"))

def read_and_convert_images(folder_path):
    # List to store bytecode of images
    image_bytecodes = []

    # Get all files in the given folder and sort them alphabetically
    files = sorted(os.listdir(folder_path))

    # Iterate through all files in the sorted list
    for filename in files:
        if filename.lower().endswith('.bmp'):
            image_path = os.path.join(folder_path, filename)
            try:
                with open(image_path, 'rb') as img_file:
                    # Read the image as bytes
                    bytecode = img_file.read()
                    binary_representation = bytecode_to_binary(bytecode)
                    ascii_representation = binary_string_to_ascii(binary_representation)
                    image_bytecodes.append(ascii_representation)
            except Exception as e:
                print(f"Failed to convert {filename}: {e}")
    
    return image_bytecodes

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
folder_path = 'src/database/Real'

# Convert images to bytecode one by one
ascii = read_and_convert_images(folder_path)







duped = duplicate_names(alay.res)

connection = mysql.connector.connect (
    host='localhost',
    user='root',
    password='nicholasrs05',
    database='tubes3_albertus'
)

try:
    if connection.is_connected():
        print('Connected to MySQL database')
        
        # Perform database operations
        cursor = connection.cursor()

        # Example query
        # query = "SELECT nama FROM biodata"
        # cursor.execute(query)
        # result = cursor.fetchall()

        for i in range (len(ascii)):
            query = "INSERT INTO sidik_jari (berkas_citra, nama) VALUES (%s, %s)"
            cursor.execute(query, (ascii[i], duped[i]))
            connection.commit()

except Error as e:
    print("Error while connecting to MySQL", e)