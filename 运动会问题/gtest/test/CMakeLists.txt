add_executable(
	unit_tests
	example.cpp
	# example_subtract.cpp
	)

target_link_libraries(
	unit_tests
	gtest_main
	# 	calendar
	)

add_test(
	NAME
	unit
	COMMAND
	${CMAKE_BINARY_DIR}/${CMAKE_INSTALL_BINDIR}/unit_tests
	)
