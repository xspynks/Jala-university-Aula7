pipeline {
    agent any

    stages {
        stage('Publish') {
            steps {
                echo 'Publishing....'
                script {
                    docker.withRegistry('https://registry.hub.docker.com', 'token-docker') {
                        def dockerImage = docker.build("xspynks/counter-image:${env.BUILD_ID}")
                        dockerImage.push("$BUILD_NUMBER")
                        dockerImage.push('latest')
                    }
                }
            }
        }
    }
}
