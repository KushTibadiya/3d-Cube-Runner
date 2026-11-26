import math

# User-defined function
def euclidean_distance(point1, point2):
    if len(point1) != len(point2):
        print("Points must have the same dimensions")
        return None

    sum_sq = 0
    for i in range(len(point1)):
        sum_sq += (point1[i] - point2[i]) * *2

    return math.sqrt(sum_sq)

# ---- User Input ----
n = int(input("Enter number of dimensions: "))

point1 = []
point2 = []

print("Enter coordinates of first point:")
for i in range(n):
    point1.append(float(input(f"Dimension {i+1}: ")))

print("Enter coordinates of second point:")
for i in range(n):
    point2.append(float(input(f"Dimension {i+1}: ")))

distance = euclidean_distance(point1, point2)

if distance is not None:
    print("Euclidean Distance:", distance)