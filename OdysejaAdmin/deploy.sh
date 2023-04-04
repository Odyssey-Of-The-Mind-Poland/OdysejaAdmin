docker build -t grzybek/odyseja-admin .
ssh grzybek docker stop $(ssh grzybek docker ps -q --filter ancestor=grzybek/odyseja-admin )
docker save grzybek/odyseja-admin | bzip2 | pv | ssh grzybek docker load
ssh grzybek docker run --net=host -d grzybek/odyseja-admin