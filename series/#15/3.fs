auto result = interpreter.run("test_basic_math.lang");
CHECK(result.output == "11");