print("Hello, World!")

# my sweet comment
if 5>2:
    print("5 is greater than 2")

# get types
x = 5
y = "John"
print(type(x))
print(type(y))

# assign multiple
x, y, z = "Orange", "Banana", "Cherry"
print(x)
print(y)
print(z)

# printing multiple values
x = "Python"
y = "is"
z = "awesome"
print(x, y, z)
x = "Python "
y = "is "
z = "awesome"
print(x + y + z)

# Global variables
x = "awesome"
def myfunc():
  x = "fantastic"
  print("Python is " + x)
myfunc()
print("Python is " + x)

print("--last call--")