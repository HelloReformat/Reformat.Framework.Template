FROM mcr.microsoft.com/dotnet/aspnet:7.0	

WORKDIR /app
EXPOSE 8080 

MAINTAINER Reformat Reformat@foxmail.com
RUN ln -sf /usr/share/zoneinfo/Asia/Shanghai /etc/localtime && \
    echo "Asia/Shanghai" > /etc/timezone 

ADD ["./*", "./"]
RUN ls -l

ENV ASPNETCORE_URLS=http://*:8080 
ENV ASPNETCORE_ENVIRONMENT=Development
# ENV ASPNETCORE_ENVIRONMENT=SIT
# ENV ASPNETCORE_ENVIRONMENT=Production

# 单文件
RUN chmod +x ./WebApi
ENTRYPOINT ["sh", "-c","./WebApi"]

# 多文件
# ENTRYPOINT ["sh", "-c","dotnet WebApi.dll --environment $ASPNETCORE_ENVIRONMENT"]

# 调试
# CMD /bin/sh