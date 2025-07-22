fn factorial(n: int) -> int {
    if n <= 1 {
        return 1;
    }
    return n * factorial(n - 1);
}

fn main() -> int {
    let value: int = 5;
    print("Result: ", factorial(value));
    return 0;
}