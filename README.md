# SCAPE_poc

# in progress
- refactor terrain gen script
- replace terrain cosine wave with animationcurve

# todo
- look into lod system
- fix projectile collision for high detail meshes
- update projectile collision so it stores list of effected vertices and doesnt update them repeatedly
- optmize projectile collision (currently takes major hit - threading could also help)
- look into threading to prevent system lock
- eventually replace diamond-square alg with perlin noise

#done
- add crosshair/cursor for mouse
- fix the R reset movement (better)
- added ability to spawn in/out vehicles
- added basic debug gui
- do not let south border wall interfere with projectiles, but make it block objects (reduced size)
- add explosion to the sphere collision with terrain
- limit the movement of camera past certain point

#notes
