################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../src/DeterminingPacketType.c \
../src/FindingNetworkDevice.c \
../src/GetInfoAboutDevice.c \
../src/LiveCapture.c \
../src/LiveCaptureLoop.c \
../src/deneme.c 

OBJS += \
./src/DeterminingPacketType.o \
./src/FindingNetworkDevice.o \
./src/GetInfoAboutDevice.o \
./src/LiveCapture.o \
./src/LiveCaptureLoop.o \
./src/deneme.o 

C_DEPS += \
./src/DeterminingPacketType.d \
./src/FindingNetworkDevice.d \
./src/GetInfoAboutDevice.d \
./src/LiveCapture.d \
./src/LiveCaptureLoop.d \
./src/deneme.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: GCC C Compiler'
	gcc -I/usr/include/pcap -O0 -g3 -Wall -c -fmessage-length=0 -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


