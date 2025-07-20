fn safe_divide(a: int, b: int) -> Option<int> {
    if b == 0 {
        return none;
    }
    return some(a / b);
}

fn use_divide() {
    let result = safe_divide(10, 2);
    if result is some(val) {
        print("Result: ", val);
    } else {
        print("Division by zero");
    }
}