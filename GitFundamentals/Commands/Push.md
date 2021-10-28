# git push

When you have a [remote](./REMOTE.md) set up you'll need to begin to move {commits}(./COMMIT.md) tothe remote.
This can b e done with the command 'git push'.

You can attach a name branch name to you command to specify where you're pushing to.

'''
git push origin main
'''

This command will push the **main** branch to the remote called **origin**. This means any commits that are in your local will be **pushed** to the remote.

### Upstream Tracking

Instead of  including the name of the remote and the b ranch you're on every time, you can set local branches to track and upstream branch.
This means  you can tell the bransh to push to its assigned upstream remote branch by using the command 'git push'.

Before soing so, you'll need to use the '-u' or '--ste-upstream' flag. This can be done on any 'git push'.

'''
git push -u origin main
'''

After this command is used, you can just use 'git push' and it will function the same way.

## Resources

-[Git PUsh Documentation](https://git-scm.com/docs/git-push)

---

[Back to home](../README.md)
