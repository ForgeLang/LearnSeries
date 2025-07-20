struct Point {
    x: float;
    y: float;
}

fn distance(p: Point) -> float {
    return sqrt(p.x * p.x + p.y * p.y);
}

fn example() {
    let origin = Point { x: 3.0, y: 4.0 };
    print("Distance: ", distance(origin)); // Output: 5.0
}