# FROM gitpod/workspace-dotnet:latest
FROM gitpod/workspace-dotnet:2022-05-08-14-31-53

# RUN curl "https://awscli.amazonaws.com/awscli-exe-linux-aarch64.zip" -o "awscliv2.zip"
# RUN unzip awscliv2.zip
# RUN ./aws/install
RUN brew install awscli

# RUN aws --version