mkdir -p bin/wasm

echo Generating LLVM Bitcode files
emcc \
	-std=c++17 \
	-s WASM=1 \
	-s LEGALIZE_JS_FFI=0 \
	-s RESERVED_FUNCTION_POINTERS=64 \
    -s ALLOW_MEMORY_GROWTH=1 \
	-s BINARYEN=1 \
	-s DISABLE_EXCEPTION_CATCHING=0 \
	-o bin/wasm/CalcManager.bc \
	-r \
	CEngine/*.cpp Ratpack/*.cpp *.cpp -I.
