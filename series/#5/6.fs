trait Addable {
    fn add(self, other: Self) -> Self;
}

fn sum<T: Addable>(a: T, b: T) -> T {
    return a.add(b);
}