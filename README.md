# Docker Demo

## Building
Build with `docker-compose build`

This will download all necessary base images and build each image in the docker compose file - `elasticsearch`, `kibana`, `api`, and `client`

## Runing
Bring the API up with `docker-compose up api`. This will bring up Elastic Search, Logstash, and Kibana automatically.

Kibana should be available at http://localhost:5601
Elastic Search should be available at http://localhost:9200/

## Load Testing
Run the client with `docker-compose up client`. This will launch one instance of the client which will automatically call the API 20 times. The results should be visible in Kibana.

Launch multiple instances of the client with `docker-compose up --scale client=n` where `n` is the number of instances to launch. Each will lauch and call the API 20 times, passing its own unique hostname. The results should be visible in Kibana.
