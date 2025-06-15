FROM mcr.microsoft.com/dotnet/sdk:8.0

VOLUME aspnet9

WORKDIR /usr/src/app

ARG API_TEMPLATE_REPO

RUN git clone ${API_TEMPLATE_REPO} .
RUN git pull

COPY zepto_v2.csv .

RUN dotnet build
RUN dotnet tool restore

ENV ASPNETCORE_KESTREL__ENDPOINTS__HTTP__URL=http://+:5000

EXPOSE 3000