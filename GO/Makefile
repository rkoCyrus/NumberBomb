GO := go
GOFLAG := 
GOFILE := numberbomb.go
# Use this if you have module
GOEXTPACKAGE := github.com/rkoCyrus/gorandomstring

.PHONY : all build clean

all : build clean

build : $(GOFILE)
	# Use this if you have module
	$(GO) get $(GOEXTPACKAGE)
	$(GO) build $(GOFILE)

clean :
	rm -f $(GOFILE)

	
