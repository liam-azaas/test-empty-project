# show info 
docker info 
 
$version = $env:VERSION;
$imageHost = "pkgs.azaas.xyz";
$imagePrefix = "pkgs.azaas.xyz/test-images";

# build and publish the docker image
docker login -u $env:DOCKER_USERNAME -p $env:DOCKER_PASSWORD  $imageHost
docker build -f Dockerfile -t "${imagePrefix}/test:${version}" .
docker push "${imagePrefix}/test:${version}"

# remove images from local cache
docker rmi "${imagePrefix}/test:${version}"
