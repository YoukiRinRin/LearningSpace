import mysql.connector

cnx = None
a =[]
try:
    cnx = mysql.connector.connect(
        user='test',  # ユーザー名
        password='test',  # パスワード
        host='localhost',  # ホスト名(IPアドレス）
        database='test'  # データベース名
    )

    cursor = cnx.cursor()

    sql = ('''
    SELECT  *
    FROM  book_branch
    ''')

    cursor.execute(sql)

    for (id_branch,branch) in cursor:
        print(branch)
        inp_YN = input()
        
        if inp_YN == 'y' or inp_YN == 'y':
            a.append(id_branch)
            
        sql2 = ('''
        SELECT  *
        FROM  books_reg_branch
        WHERE branch_id = '%s'
        ''')
        param = a[0]
        
        
        cursor.execute(sql2,param)

       

        for (book_id,branch_id) in cursor:
            print('aaa')
            sql3 = ('''
            SELECT  *
            FROM  books
            WHERE id_books = '%s'
            ''')
            cursor.execute(sql3,branch_id)
        
        print('終わり')



    
    cursor.close()

    
except Exception as e:
    print(f"Error Occurred: {e}")

finally:
    if cnx is not None and cnx.is_connected():
        cnx.close()