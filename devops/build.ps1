# show info 
docker info 

$env:VERSION = "1.0"
echo $env:VERSION

# build and publish the docker image
# docker login -u $env:USERNAME -p $env:PASSWORD
docker build -f devops/Dockerfile -t test-$env:VERSION .
# docker push test-$env:VERSION

# remove images from local cache
# docker rmi test-$env:VERSION
