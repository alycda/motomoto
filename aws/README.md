## Cloudformation

- Create User/group motomoto
- Create Buckets for UI & Lambda
- Creade Lambda Role

## USER(s)

### motomoto

- can deploy to 2 buckets (arn:aws:s3:::motomoto*)
    + motomoto-ui
    + motomoto-app
- can create lambda 
    + lambda:GetFunctionConfiguration
        * arn:aws:lambda:us-west-2:697616471496:function:TheNewPanelists
    + iam:ListRoles
    + iam:ListPolicies
    + iam:CreateRole
    + iam:AttachRolePolicy
    + iam:PassRole
    + iam:GetRole