FROM mcr.microsoft.com/vscode/devcontainers/dotnet:6.0

# Node.js version: none, lts, 16, 14, 12, 10
ARG NODE_VERSION="16"
RUN if [ "${NODE_VERSION}" != "none" ]; then su vscode -c "umask 0002 && . /usr/local/share/nvm/nvm.sh && nvm install ${NODE_VERSION} 2>&1"; fi

# Add dotnet ef tool
RUN dotnet tool install --global dotnet-ef
ENV PATH $PATH:/root/.dotnet/tools

# Update args in docker-compose.yaml to set the UID/GID of the "vscode" user.
#ARG USER_UID=1000
#ARG USER_GID=$USER_UID
#RUN if [ "$USER_GID" != "1000" ] || [ "$USER_UID" != "1000" ]; then groupmod --gid $USER_GID vscode && usermod --uid $USER_UID --gid $USER_GID vscode; fi


# [Optional] Uncomment this section to install additional OS packages.
# RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
#     && apt-get -y install --no-install-recommends <your-package-list-here>

# [Optional] Uncomment this line to install global node packages.
# RUN su vscode -c "source /usr/local/share/nvm/nvm.sh && npm install -g <your-package-here>" 2>&1