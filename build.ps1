# restore
nuget.exe restore WebApplication1.sln

# build & publish
msbuild "WebApplication1\WebApplication1.csproj" /p:Configuration=Release -r:False /p:DeployOnBuild=True /p:DeployDefaultTarget=WebPublish /p:WebPublishMethod=FileSystem /p:DeleteExistingFiles=True /p:publishUrl=../output
