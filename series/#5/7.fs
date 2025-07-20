fn compute() -> int {
    let mut result: int = 0;
    for i in 0..100 {
        result = result + i;
    }
    return result;
}

fn parallel_sum() {
    let t1 = spawn compute();
    let t2 = spawn compute();

    let r1 = join t1;
    let r2 = join t2;

    print("Total: ", r1 + r2);
}
