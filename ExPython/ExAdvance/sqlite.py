import sqlite3

conn=sqlite3.connect("test.db")
c=conn.cursor()

#c.execute('''create table person(id int primary key,name text,age int)''')
#conn.commit()
#print("database file is created")

#c.execute("insert into person values(1,'jack paul',27)")
#c.execute("insert into person values(?,?,?)",[(2,'Kate Green',30)])
persons=[(3,"Nancy",32),(4,"David",33),(5,"Obama",55)]
#c.executemany('insert into person values(?,?,?)',persons)

print("data are inserted")
#conn.commit()

#c.execute('select name from person order by name')

#print(c.fetchone())
#print(c.fetchone())
#print(c.fetchall())

for row in c.execute('select name,age from person order by age'):
    print(row)
    print(row[0])





conn.close()

