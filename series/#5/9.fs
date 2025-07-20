fn print_slice(data: slice<int>) {
    for i in 0..data.len {
        print(data[i]);
    }
}

fn use_slice() {
    let arr = [1, 2, 3, 4];
    print_slice(arr[1..3]); // Prints: 2, 3
}