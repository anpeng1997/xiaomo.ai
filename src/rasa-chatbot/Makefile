train:
	rasa train --domain domain.yml --data data --config config.yml --out models

train-nlu:
	rasa train nlu -u data/nlu -c config.yml --out models/nlu

run:
	rasa run --endpoints endpoints.yml --enable-api -m models --credentials credentials.yml --debug

run-nlu:
	rasa run --enable-api -m models/nlu

run-cmdline:
	rasa shell --endpoints endpoints.yml -m models --debug

run-graph:
	rasa visualize --domain domain.yml --stories data/core --config config.yml --nlu data/nlu

run-x:
	rasa x -m models --endpoints endpoints.yml

run-interactive:
	rasa interactive -m models --endpoints endpoints.yml