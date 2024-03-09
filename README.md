# Enforcer Legacy Readme
Actual readme in release folder  
Full Changelog in Release folder
- Adds the Enforcer from Risk of Rain 1
- Includes a bunch of unlockable alternate skills and skins
- Includes support for ClassicItems' Ancient Scepter

[![](https://cdn.discordapp.com/attachments/469291841859092488/782484337379246110/unknown.png)]()

[![](https://cdn.discordapp.com/attachments/739704939671978024/787500376793677844/screen1.png)]()
[![](https://cdn.discordapp.com/attachments/739704939671978024/787500388198514728/screen2.png)]()

[![](https://cdn.discordapp.com/attachments/469291841859092488/782568907009425418/texEnforcerIcon.png)]()

Join the discord server to share any feedback/bugs/suggestions- https://discord.gg/HpQB9fC

## Credits
Gnome - Coding
rob - Cooding
TheTimesweeper - Coooding
Enigma - Cooooding
PapaZach - Skill icons
Jot - Animations
DarkLordLui - Animations
Violet Chaolan - Sounds
LucidInceptor - Modeling
bruh - Modeling, swag
SalvadorBunny - Heavy TF2 Minecraft skin
Destructor - Mod icon
Draymarc - Concepts
Lethan - Screenshots
Moffein - Idea Guy™
Ruxbieno - Idea Guy™
Swuff - Idea Guy™

And big thanks to everyone testing and giving their feedback, the mod wouldn't be the same without it

## Skills

| Skill | | Description | Stats |
|:-|-|------|-|
| Riot Shotgun | ![](https://cdn.discordapp.com/attachments/739696016755785859/782468730759675934/enforcer_primaryV2.png) | Fire a short range `piercing` blast for `8x45%` damage. | Proc: `0.5` |
| Shield Bash | ![](https://cdn.discordapp.com/attachments/739696016755785859/782468850683871232/enforcer_secondaryV2.png) | `Bash` nearby enemies away for `250%` damage. Use while sprinting to perform a `Shoulder Bash` for `450%` damage instead. `Deflects Projectiles`. | Proc: `1.0`, CD: `6 sec` |
| Shoulder Bash |  | Short charge that stuns. Hitting heavier enemies deals up to `700%` damage. | Proc: `1.0` |
| Tear Gas | ![](https://cdn.discordapp.com/attachments/739696016755785859/782468892445376530/enforcer_utilityV2.png) | Throw a grenade that explodes into tear gas that leaves enemies `Impaired`. Lasts for 16 seconds. | CD: `24 sec` |
| Blind |  | Reduces `movement speed` by `75%`, `attack speed` by `25`, and `armor` by `20`|
| Protect and Serve | ![](https://cdn.discordapp.com/attachments/739696016755785859/782468993033306122/enforcer_shieldupV2.png) | Take a defensive stance `blocking` all damage from the front. `Increases your rate of fire` but prevents sprinting and jumping. | CD: `0 sec` |

### Unlockable Alts (spoiler alert)

| Skill | | Description | Stats |
|:-|-|------|-|
| Super Shotgun | ![](https://cdn.discordapp.com/attachments/739696016755785859/782468767124815902/enforcer_primary2V2.png) | Fire a powerful short range blast for `16x80%` damage. Has harsh damage falloff. | Proc: `0.75` |
| Assault Rifle | ![](https://cdn.discordapp.com/attachments/739696016755785859/782468797017227304/enforcer_primary3V2.png) | Fire a burst of bullets bullets dealing `3x75%` damage. Fires 6 bullets instead during Protect and Serve. | Proc: `0.75` |
| Stun Grenade | ![](https://cdn.discordapp.com/attachments/739696016755785859/782468931159457832/enforcer_utility2V2.png) | `Stunning`. Launch a stun grenade, dealing `400%` damage. Store up to 3 grenades. | Proc: `0.6`, CD: `8 sec` |

[![Gnome's true dedication](https://i.imgur.com/txUzvAY.png)]()

## Known Issues
- Cancelling shield with sprint does not work properly in multiplayer
- Pending an R2API update, some achievements can't be unlocked in multiplayer (they only work for host or single player)
- RyanSkinAPI causes the model to be invisible sometimes
- Life Savings may not work

## Future Plans
- More alternate skills
___
## Legacy Changelog

`2.2.6`
- King Dedede's bonus health regen is now disabled upon taking damage, and bleed now cuts ALL regen by 100% (only applies to Starstorm 2 invasion variant)

`2.2.5`
- Added compatibility with Standalone Ancient Scepter and removed ClassicItems compatibility

`2.2.4`
- Fixed a minor issue with skins

`2.2.3`
- Added compatibility for Starstorm 2's void event- the default invasion event is still here, only now with a twist
- Added Enforcer's Grand Mastery skin- huge thanks to bruh for the model
- Added work in progress alt utility for Heavy TF2, locked behind config

`2.2.2`
- Updated skill icons
- Networked shield block effect
- Added item displays for Plague Mask and Plague Hat from Supply Drop
- Heavy TF2 changes below
- Added Grand Mastery skin, available via Starstorm 2 crosscompat
- Added new minigun sounds
- Updated a lot of VFX
- Updated uppercut animation
- Updated skin icons
- Tweaked camera angle on spawn
- Tweaked hammer hitstop to stop it from interfering with movement
- Networked salute emote, oops
- Networked melee hit sounds

`2.2.1`
- Unsneeded the feed

`2.2.0`
- Added a new skin for Heavy TF2
- Updated hammer sounds

`2.1.9`
- Fixed salute emote doing nothing

`2.1.8`
- Fixed Dominance breaking when used on dedicated servers

`2.1.7`
- Fixed Fortnite dances (sorry)

`2.1.6`
- Added salute emote
- Tweaked sprint animation timing
- Tweaked uppercut animation
- Added work in progress alt primary (enable cursed in config)
- Removed all reflection from code, improving performance
- Fixed SSG reload animation
- Fixed some stupid vanilla EffectCatalog errors
- Fixed Red Whip activating while using certain primaries

`2.1.5`
- Quick hotfix, King Dedede's skills were replacing Commando's by mistake

`2.1.4`
- Added a custom King Dedede boss, must be enabled via config- spawns on Sky Meadow and post-loop Titanic Plains
- Added a new skill variant for Heavy TF2, must be enabled via cursed config
- Fixed Heavy TF2's spawn animation
- Fixed Heavy TF2's umbra not having proper AI
- Increased size of secret boss
- Added passive regen VFX
- Tweaked Minecraft skin and improved rig

`2.1.3`
- Updated King Dedede's Minecraft skin- special thanks to SalvadorBunny for making it!
- Made Breaching Hammer an actual skill (not sure if it's still locked behind config to be honest)
- Improved Stun Grenade aim
- Tweaked King Dedede hammer hitboxes so they can be more reliably blocked by the shield
- King Dedede is now immune to the void
- Improved Golden Hammer swing animations
- Golden Minigun now aims up and down
- Added Enforcer idlein animation
- Toggling sirens now toggles an alternate run animation because letting this feature sit around unused was depressing
- Fixed Shattering Justice not properly replacing the hammer

`2.1.2`
- Optimized all gases, should no longer kill fps after using too many on a stage
- Fixed rest emote not being looped

`2.1.1`
- Fixed an issue causing the game to softlock after Mithrix's defeat
- Fixed a minor camera bug
- Fixed Dedede's rig
- Fixed big teleporter particles
- Updated shield model
- Added an experimental Heavy TF2 skin, still a heavy work in progress

`2.1.0`
- Partially reverted some camera stuff to fix bugs resulting from it- smoother camera now only works in singleplayer

`2.0.9`
- Fixed stuff

`2.0.7`
- Adjusted some camera things, improving overall smoothness
- Minor optimization to shotgun shells
- King Dedede model tweaks- Improved rig, 200% less jank squish, added minigun
- Tweaked Heavy TF2 spawn animation to somewhat more consistently face the camera

`2.0.6`
- Fixed Aetherium item displays
- Lots of King Dedede changes
- No longer requires Enforcer to unlock- meaning someone else can play him and get the unlock for everyone
- Added fall damage immunity and adaptive armor to boss variant
- Capped maximum spawns per invasion to 1(can revert in config if you like the challenge)
- Added a new skin(Must be enabled via cursed config(I sincerely apologize))
- Added Supply Drop item displays
- Tweaked secondary visuals
- Fixed uppercut not playing sounds in multiplayer
- Increased Dominance (Minigun) base duration from 0.9s to 1.2s
- Dominance (Minigun) now explodes projectiles, rather than simply destroying them

`2.0.5`
- Alright the uppercut animation is ACTUALLY 100% fixed now, if it's not we will deprecate the mod
- Some more animation and VFX tweaks
- Minigun variant of Dominance is now shown in loadout
- Modded difficulties above Monsoon are now counted for Monsoon exclusive content
- Fixed Dripforcer clipping issues
- Gave Enforcer's umbra proper AI
- Changed Herobrine's unlock text to something more accurate

`2.0.4`
- Fixed multiplayer animations for real this time
- Fixed minigun crosshair not working properly for spectators
- Fixed certain effects being duplicated in multiplayer, causing excessive screenshake
- Fixed Little Disciple and Leech item displays
- Lowered minigun secondary damage to from 1000% to 600%- Backup Mags were a little excessive
- Lowered aerial slam minimum radius to 6m from 12m, max unchanged

`2.0.3`
- Added Supply Drop item displays(missed change from 2.0)
- Added config for shotgun shell sounds
- Adjusted Leech placement
- Fixed Enforcer always being elevated slightly above the ground
- Heavy TF2 changes- goal is to make him more fluid and address his low durability
- Boss variant now uses unique boss scaling, should no longer be a pushover
- Added config to enable invasions as any character, for fun
- Various animation tweaks
- Base max health increased from 160 to 224
- Max health growth increased from 48 to 56
- Passive regen increased from 2% to 2.5%
- Lowered primary base duration from 1.2s to 1.05s, tweaked animation
- Fixed duplicate effects on primary
- Fixed bugged secondary animation in multiplayer
- Secondary slam now only activates when falling and looking down
- Secondary slam now carries over speed from the charge state when calculating impact radius
- Uppercut cancel window now begins at the start of the uppercut rather than the end
- Minigun spread now ramps up more slowly
- Minigun self slow reduced
- Minigun swap no longer prevents jumping, shorter slow duration when sheathing minigun
- Minigun stance armor buff increased from 50 to 60
- Fixed Happiest Mask placement
- Added drip
- Life Savings still does nothing
- I don't even know if the problem is on our end nothing makes sense
- Just don't grab the item

`2.0.2`
- Made Enforcer: Enforcing Perfection require much less Bustling Fungus to unlock
- Fixed some effects being duplicated in multiplayer
- Tweaked Herobrine spawn mechanics

`2.0.1`
- Spotted another readme typo, hopefully last one for today

`2.0.0`
- Fixed a typo in readme

`1.1.5`
- Updated character portrait
- Updated Shield Bash Icon
- Shield Bash now pushes allies(toggleable via config)
- Fixed a minor bug

`1.1.4`
- Fixed absurd Stun Grenade knockback

`1.1.3`
- Updated skill icons
- Added a new skin, moved some old skins to a config option to prevent bloat
- Updated shotgun shells, added sounds
- Added fancy shoulder light effect- made it flash on level up too because I'm a shameless showoff
- Buff Riot Shotgun damage to 8x45% and SSG to 16x80%- resetting config recommended
- Riot Shotgun's spread is now tightened during Protect and Serve
- Increased Protect and Serve self slow from 50% to 65%
- Shield Bash now has minimum knockback, so light monsters like wisps and jellyfish can now get launched
- Added a config option to add a cap to the knockback to prevent bosses from being thrown around
- Tear Gas no longer snaps to the ground, meaning it's effective on flying monsters
- Actually fixed Mustard Gas not applying debuff for real this time
- Mustard Gas damage doubled, proc coefficient raised from 0 to 0.05
- Stun Grenade visuals updated to better match his RoR1 grenade
- Added knockback to Stun Grenade
- Added item displays for the new Aetherium items and SivsItems
- Added pig
- Fixed Enforcer's logbook display using the wrong shader
- Tweaked shotgun volume

`1.1.2`
- Reworked Assault Rifle- resetting config is recommended
- Even more model tweaks, fixed Bungus head clipping
- Added back missing shoulder lights
- Added new skin
- Loadout choices are now visible in character select
- Added SSG bullet tracer
- Added sounds for the Bungus guns
- Fixed Mustard Gas not applying debuff
- Fixed Fresh Meat being unreasonably huge
- Shield Bash into P&S transition made smoother
- Tweaked Femforcer skin
- Added skateboard sounds and fixed some bugs
- Unfinished Breaching Hammer is now an actual melee attack

`1.1.1`
- Tweaked model some more
- Fixed item displays not showing up on the Assault Rifle
- Added skateboard model and animations- must be enabled in config to use it

`1.1.0`
- Updated model

`1.0.9`
- Added Femforcer- disabled by default, must be enabled via config (thanks modanon!)
- Added more bungus weapons
- Buffed Assault Rifle damage to 80%- config must be reset or edited manually to get the new value
- Buffed Assault Rifle proc coefficient during P&S to 0.4
- Buffed Assault Rifle fire rate
- Lowered Assault Rifle spread
- Added configuration for Assault Rifle
- Added config option to revert the Engi shield
- Added a new emote
- Fixed some animation weirdness
- Fixed Fresh Meat being huge

`1.0.8`
- Added gun shooting animations
- Tweaked sprint animation
- Tweaked aim animation
- Added item displays for items from the Aetherium mod
- Added support for Ancient Scepter!
- Tear Gas > Mustard Gas: Gas now deals 100% damage per second
- Stun Grenade > Shock Grenade: Grenade does more damage, has a larger radius and applies shock rather than stun
- Half reverted Engi skin's shield
- Fixed Sawmerang item display
- Fixed weird shield overlay on certain skins

`1.0.7`
- Fixed another minor bug

`1.0.6`
- Fixed a null projectile being registered to the catalog possibly causing bugs

`1.0.5`
- Updated Engineer skin's shield
- Updated Engineer skin's shotgun- only Riot Shotgun for now, other weapons coming soon
- Updated Doomguy skin's shield
- Updated Needler texture
- Lowered the amount of Bustling Fungus needed for Enforcer: Enforcing Perfection even more
- Fixed Shattering Justice placement- left the old hammer placement as a config option
- Fixed deflected projectiles sometimes not hitting the original owner of the projectile
- Fixed Needler not dropping when ragdolling
- Fixed Crowdfunder hitting the shield during Protect & Serve- the drone wasn't actually needed but it's staying
- Updated Super Massive Leech item display
- Added a config option to enable unfinished skills
- Changed config to use proper keycodes- this will reset your keybinds back to default but makes changing them easier, resetting config is recommended
- Fixed a typo in Shield Bash's description

`1.0.4`
- Increased Assault Rifle damage to 65%; 40% was a bug and unintended, sorry!
- Added animation when using the Needler
- Added a custom crosshair for Visions of Heresy- it's applied to every survivor but this can be toggled off via config
- Due to complaints, Shattering Justice has been placed somewhere more serious
- Lowered amount of Bustling Fungus required for Enforcer: Enforcing Perfection from 250 to 200
- Fixed Riot Shotgun firing no bullets when configured to fire only one
- Fixed an issue with Needler model still being visible even after getting rid of the item
- Fixed Backup Mags on the Needler being huge
- Fixed Visions of Heresy being hidden inside the head
- Fixed sirens not going off when deflecting golem lasers

`1.0.3`
- Nerfed Super Shotgun fire rate; it was actually bugged and was never supposed to have the same fire rate as Riot Shotgun
- Fixed bug with Super Shotgun ejecting a stupid amount of shells, added unique shells
- Added a Needler gun for Visions of Heresy
- Calm idle stance now only triggers when out of combat
- Fixed bug causing shield to stop blocking damage if sirens were toggled during Protect and Serve
- Fixed the annoying (but harmless) warning messages on startup
- Renamed 'Blinded' debuff to 'Impaired'
- Added the host only warning to the Rules of Nature achievement since that one seems to be bugged too
- Some minor texture tweaks
- Fixed a rare bug involving a pink cube and Enforcer flying into space? Never actually found the cause but that cube is deleted so it should be gone

`1.0.2`
- Added keybinds to config
- Added a custom Crowdfunder Drone display, to try and fix the Crowdfunder bug(it didn't)
- Reworked Super Shotgun
- Added config for base stats and Riot Shotgun, more might come eventually but this is really tedious to code
- Enforcing Perfection achievement now scales better with the amount of Bustling Fungus you have

`1.0.1`
- Added dependencies oops

`1.0.0`
- Initial release

if you read all this you're cool