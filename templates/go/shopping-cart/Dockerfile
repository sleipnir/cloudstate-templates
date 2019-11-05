FROM golang

WORKDIR /go/src/{application-name}

ADD . /go/src/{application-name}

RUN go build .

ENV HOST 127.0.0.1
ENV PORT 8088

EXPOSE 8088

ENTRYPOINT ./{application-name}

