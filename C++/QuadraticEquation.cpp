#include <cmath>

int quadraticEquation(int a, int b, int c) {
    int discriminant = b*b - 4*a*c;  // calculate the discriminant
    int root = (-b + sqrt(discriminant)) / (2*a);  // calculate the root with the + sign
    return root;
}
