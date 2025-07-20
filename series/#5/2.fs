fn demo() {
    let x: int = 10;       // Immutable by default
    let mut y: int = 20;   // Mutable with 'mut'

    y = y + x;
    print(y);              // Output: 30
}