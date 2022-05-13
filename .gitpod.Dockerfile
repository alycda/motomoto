# FROM gitpod/workspace-dotnet:latest
FROM gitpod/workspace-dotnet:2022-05-08-14-31-53

# RUN curl "https://awscli.amazonaws.com/awscli-exe-linux-aarch64.zip" -o "awscliv2.zip"
# RUN unzip awscliv2.zip
# RUN ./aws/install
RUN brew install awscli

# RUN aws --version

RUN dotnet new -i Amazon.Lambda.Templates
RUN dotnet tool install -g Amazon.Lambda.Tools
RUN export PATH="$PATH:/home/gitpod/.dotnet/tools"

# RUN cat << \EOF >> ~/.bash_profile \
#   # Add .NET Core SDK tools \
#   export PATH="$PATH:/home/gitpod/.dotnet/tools" \
#   EOF \

RUN pip install boto3