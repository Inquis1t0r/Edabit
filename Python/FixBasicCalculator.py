def basic_calculator(a, o, b):
    result = 0
     
    if(o == "+"):
        return a + b
    elif (o == "-"):
        return a - b
    elif (o == "/" or b != 0):
        return a / b
    elif (o == "*"):
        return a * b
    return result
