# Problem:
# Write a program that translates a distance between the following 8 units: m, mm, cm, mi, in, km, ft, yd.
# Use the tabs below:

input_num = float(input())

input_unit = input()
output_unit = input()



if input_unit == "mm":
    if output_unit == "mm":
        print(input_num * 1,"mm")

    elif output_unit == "cm":
        print(input_num / 10,"cm")

    elif output_unit == "m":
        print(input_num / 1000,"m")

    elif output_unit == "mi":
        print((input_num / 1000) * 0.000621371192,"mi")

    elif output_unit == "in":
        print((input_num / 1000) * 39.3700787,"in")

    elif output_unit == "km":
        print((input_num / 1000) * 0.001,"km")

    elif output_unit == "ft":
        print((input_num / 1000) * 3.2808399,"ft")

    elif output_unit == "yd":
        print((input_num / 1000) * 1.0936133,"yd")

elif input_unit == "cm":
     if output_unit == "mm":
        print(input_num * 10,"mm")

     elif output_unit == "cm":
         print(input_num * 1,"cm")

     elif output_unit == "m":
         print(input_num / 100,"m")

     elif output_unit == "mi":
         print((input_num / 100) * 0.000621371192,"mi")

     elif output_unit == "in":
         print((input_num / 100) * 39.3700787,"in")

     elif output_unit == "km":
         print((input_num / 100) * 0.001,"km")

     elif output_unit == "ft":
         print((input_num / 100) * 3.2808399,"ft")

     elif output_unit == "yd":
         print((input_num / 100) * 1.0936133,"yd")

elif input_unit == "mi":
     if output_unit == "mm":
        print((input_num * 1609.344)* 1000,"mm")

     elif output_unit == "cm":
         print((input_num * 1609.344) * 100,"cm")

     elif output_unit == "m":
         print(input_num * 1609.344,"m")

     elif output_unit == "mi":
         print(input_num * 1,"mi")

     elif output_unit == "in":
         print((input_num * 1609.344) * 39.3700787,"in")

     elif output_unit == "km":
         print((input_num * 1609.344) * 0.001,"km")

     elif output_unit == "ft":
         print((input_num * 1609.344) * 3.2808399,"ft")

     elif output_unit == "yd":
         print((input_num * 1609.344) * 1.0936133,"yd")

elif input_unit == "in":
     if output_unit == "mm":
        print((input_num * 0.0254)* 1000,"mm")

     elif output_unit == "cm":
         print((input_num * 0.0254) * 100,"cm")

     elif output_unit == "m":
         print(input_num * 0.0254,"m")

     elif output_unit == "mi":
         print((input_num * 0.0254) * 0.000621371192,"mi")

     elif output_unit == "in":
         print((input_num * 1),"in")

     elif output_unit == "km":
         print((input_num * 0.0254) * 0.001,"km")

     elif output_unit == "ft":
         print((input_num * 0.0254) * 3.2808399,"ft")

     elif output_unit == "yd":
         print((input_num * 0.0254) * 1.0936133,"yd")

elif input_unit == "km":
     if output_unit == "mm":
        print((input_num * 1000)* 1000,"mm")

     elif output_unit == "cm":
         print((input_num * 1000) * 100,"cm")

     elif output_unit == "m":
         print(input_num * 1000,"m")

     elif output_unit == "mi":
         print((input_num * 1000) * 0.000621371192,"mi")

     elif output_unit == "in":
         print((input_num * 1000) * 39.3700787,"in")

     elif output_unit == "km":
         print((input_num * 1),"km")

     elif output_unit == "ft":
         print((input_num * 1000) * 3.2808399,"ft")

     elif output_unit == "yd":
         print((input_num * 1000) * 1.0936133,"yd")

elif input_unit == "ft":
     if output_unit == "mm":
        print((input_num / 3.2808399)* 1000,"mm")

     elif output_unit == "cm":
         print((input_num / 3.2808399) * 100,"cm")

     elif output_unit == "m":
         print(input_num / 3.2808399,"m")

     elif output_unit == "mi":
         print((input_num / 3.2808399) * 0.000621371192,"mi")

     elif output_unit == "in":
         print((input_num / 3.2808399) * 39.3700787,"in")

     elif output_unit == "km":
         print((input_num / 3.2808399) * 0.001,"km")

     elif output_unit == "ft":
         print((input_num * 1),"ft")

     elif output_unit == "yd":
         print((input_num / 3.2808399) * 1.0936133,"yd")

elif input_unit == "yd":
     if output_unit == "mm":
        print((input_num / 1.0936133)* 1000,"mm")

     elif output_unit == "cm":
         print((input_num / 1.0936133) * 100,"cm")

     elif output_unit == "m":
         print(input_num / 1.0936133,"m")

     elif output_unit == "mi":
         print((input_num / 1.0936133) * 0.000621371192,"mi")

     elif output_unit == "in":
         print((input_num / 1.0936133) * 39.3700787,"in")

     elif output_unit == "km":
         print((input_num / 1.0936133) * 0.001,"km")

     elif output_unit == "ft":
         print((input_num / 1.0936133) * 3.2808399,"ft")

     elif output_unit == "yd":
         print((input_num / 1),"yd")

elif input_unit == "m":
     if output_unit == "mm":
        print(input_num * 1000,"mm")

     elif output_unit == "cm":
         print(input_num  * 100,"cm")

     elif output_unit == "m":
         print(input_num * 1,"m")

     elif output_unit == "mi":
         print(input_num  * 0.000621371192,"mi")

     elif output_unit == "in":
         print(input_num * 39.3700787,"in")

     elif output_unit == "km":
         print(input_num  * 0.001,"km")

     elif output_unit == "ft":
         print(input_num * 3.2808399,"ft")

     elif output_unit == "yd":
         print(input_num * 1.0936133,"yd")



