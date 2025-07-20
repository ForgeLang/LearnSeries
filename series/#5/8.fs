fn open_file(path: string) -> Result<File, string> {
    if path == "" {
        return err("Empty path");
    }
    return ok(File {});
}

fn main() {
    let file = open_file("log.txt");
    if file is ok(f) {
        print("Opened successfully");
    } else if file is err(e) {
        print("Error: ", e);
    }
}