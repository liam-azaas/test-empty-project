# show info 
docker info 
 
$version = $env:VERSION;
$imageHost = "azinternal-devops-01.southeastasia.cloudapp.azure.com:18000";

# build and publish the docker image
docker login -u $env:DOCKER_USERNAME -p $env:DOCKER_PASSWORD  $imageHost
docker build -f Dockerfile -t "${imageHost}/test:${version}" .
docker push "${imageHost}/test:${version}"

# remove images from local cache
docker rmi "${imageHost}/test:${version}"
