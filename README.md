# Serverless Templates
A list of servless templates for use with visual studio code.

# Example usage
If you have not done so, you will need to install [serverless](https://github.com/serverless/serverless#readme) and setup your [provider credentials](https://github.com/serverless/serverless/blob/master/docs/providers/aws/guide/credentials.md).

Once you have done the above:
1. Create your repository in github and clone it locally (do not yet navigate into the folder)
1. Navigate to your cloned repository and add the desired serverless template, e.g.
```
cd <project-name>
serverless create --template-url https://github.com/rguerra712/serverless-templates/tree/master/node/aws-typescript-tests
```
1. Move the template from the subdirectory to the project path (including hidden files), e.g.
```
mv --target-directory=. aws-typescript-tests/*
mv --target-directory=. aws-typescript-tests/.[!.]*
rm -rf aws-typescript-tests/
```

Once you have created your template be sure to **change the service name from `hello` and update these changes in the `serverless.yml` configuration file**. Additionally, you will need to **change the `service` property** to a more appropriate name.

You will also want to update the `package.json` file more appropriately represent your package (you may optionally want to use the [github package builder](https://www.npmjs.com/package/github-package-builder) to build your package file from your github repository).
