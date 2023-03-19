XBUILD=/Applications/Xcode_14.2.0.app/Contents/Developer/usr/bin/xcodebuild
ROOT=$(PWD)
PROJECT_ROOT=$(ROOT)/../external/FLEX
PROJECT=$(PROJECT_ROOT)/FLEX.xcodeproj
BUILD_ROOT=$(PROJECT_ROOT)/build
TARGET_IOS="FLEX"
PROJECTNAME=FLEX
OUTPUT=$(ROOT)/Build
FRAMEWORK_PATH=Products/Library/Frameworks/FLEX.framework
FRAMEWORKS=$(ROOT)/Frameworks
FRAMEWORKS_IOS=$(ROOT)/Frameworks/ios
BINDING_OUTPUT=$(ROOT)/../bindings
IOS_SDK=iphoneos16.2

all: iossimulator iosdevice xcframework dotnet

build: iossimulator iosdevice xcframework

pack: build nuget

iossimulator:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_IOS) -destination "generic/platform=iOS Simulator" -archivePath $(BUILD_ROOT)/simulator.xcarchive -sdk iphonesimulator SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

iosdevice:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_IOS) -destination "generic/platform=iOS" -archivePath $(BUILD_ROOT)/iOS.xcarchive -sdk iphoneos SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

xcframework:
	rm -rf $(BUILD_ROOT)/$(PROJECTNAME).xcframework
	$(XBUILD) -create-xcframework -framework $(BUILD_ROOT)/simulator.xcarchive/$(FRAMEWORK_PATH) -framework $(BUILD_ROOT)/iOS.xcarchive/$(FRAMEWORK_PATH) -output $(BUILD_ROOT)/$(PROJECTNAME).xcframework
	rm -rf $(FRAMEWORKS)
	mkdir -p $(FRAMEWORKS)
	cp -R $(BUILD_ROOT)/ $(FRAMEWORKS)

dotnet:
	dotnet build -c Release

nuget:
	dotnet pack --configuration Release

sharpie:
	sharpie bind --sdk=$(IOS_SDK) --output="$(BINDING_OUTPUT)" --namespace="Drastic.$(PROJECTNAME)" --scope="$(PROJECT_ROOT)/Classes" $(PROJECT_ROOT)/Classes/Manager/FLEXManager.h