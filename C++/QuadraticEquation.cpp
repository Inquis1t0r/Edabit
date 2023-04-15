#include <cmath>

void quadraticEquation(int a, int b, int c, int* root) {
    int discriminant = b * b - 4 * a * c;  // calculate the discriminant
    *root = (-b + sqrt(discriminant)) / (2 * a);  // calculate the root with the + sign
}
