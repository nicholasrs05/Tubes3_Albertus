import mysql.connector
from mysql.connector import Error
import alay
import random

connection = mysql.connector.connect (
    host='localhost',
    user='root',
    # password='nicholasrs05',
    database='tubes3_albertus'
)

try:
    if connection.is_connected():
        print('Connected to MySQL database')
        
        # Perform database operations
        cursor = connection.cursor()

        # Example query
        query = "SELECT nama FROM biodata"
        cursor.execute(query)
        result = cursor.fetchall()
        oldName = []
        newName = []
        for row in result:
            options = [random.choice([True, False]) for i in range (3)]
            while True not in options:
                options = [random.choice([True, False]) for i in range (3)]
            oldName.append(row[0])
            newName.append(alay.HumanToABG(row[0], options))
        for i in range (len(newName)):
            query = "UPDATE biodata SET nama = %s WHERE nama = %s"
            cursor.execute(query, (newName[i], oldName[i]))
            connection.commit()
        print(oldName)
        


except Error as e:
    print("Error while connecting to MySQL", e)