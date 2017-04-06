# Project Dropshot
Project Dropshot is a custom made server for the sunsetted game Uberstrike and is being developed by [@festivaldev](https://github.com/festivaldev).

## Features
- **Authentication**  
All Uberstrike accounts you create can be linked to a Steam-id. When starting the game, Uberstrike will provide the server with your Steam-id and log you in.
- **Inventory and Loadout**  
The server will save your loadout and inventory when you "buy" a new item or make changes to your loadout, so you won't lose progress when disconnecting.
- **Massive Shop Sale**  
The shop contains 99% of all items ever released in Uberstrike. Every item has no level lock, no tier and no price. You can buy all items in the shop for free.
- **Customization**  
The server relies heavily on JSON files to store it's components and data. This enables you to customize the shop (including prices, item names, available items, etc.), the maps (not the maps itself but rather their name, their available game modes, max/min player count, the thumbnail, etc.) or account data (username, rank, money, etc.).
  
## Screenshots/Videos
Coming soon!

## Known Issues
#### Grenades do not explode on secondary fire. / Miniguns do not warm up.
*__Affects__: The Final World, The Final Kiss, Sabertooth, Battlesnake, Battlesnake [Dragon]*  
Uberstrike has the most complicated secondary fire system ever. At the moment we have no idea how to set up these weapons correctly.  
#### Some stats don't match the original counterpart.
*__Affects__: All items in the shop*  
We have no *official* item data. All weapon stats are based on guides and wikis. We do have screenshots showing some weapon stats, but the in-game statistics (those bars when you hover over a weapon) are relative to all weapons in the category and don't provide any helpful information whatsoever. However, you can customize those values yourself.  
#### The game freezes when trying to buy credits.
The game requests all credit packs from the server, which does not provide a function for that. We are going to implement the function, but it will return nothing.

## FAQ
#### "Bullshit. This is just clickbait. F$#k off!"
Nope, this is a 100% real and working. If you don't think so, enjoy your life without Uberstrike.  
#### But how?
Fortunately, Uberstrike is developed using the Unity engine and C#. C# is a programming language designed by Microsoft and gets compiled to Common Intermediate Language (CIL). With tools like [ILSpy](https://github.com/icsharpcode/ILSpy) oder [dnSpy](https://github.com/0xd4d/dnSpy) you can decompile CIL code back to C# and make it readable again. Uberstrike's client-server communitcation is based on the Windows Communication Framework which uses WebServices to answer requests. A proxy software like Charles reveals more details about the contracts used. All you need to do, is re-create these WebServices accordingly.  
#### Can I try this?
Yes, but at the moment it's complicated af. You would need a Windows Server with ASP.NET and a SSL certificate (we use [IIS](https://www.iis.net/) for this), the Uberstrike Steam client (you can still download this version directly via **steam://install/291210**) and a patch made by us. We know this is a complex setup but we are trying to simplify this. Stay tuned!  
#### Will you implement ...?
Probably not. Our plan is to create a server which provides all functions needed in order to play. Hence we didn't plan on implementing the clan system, the global chat lobby, the friend system, levels or statistics. However, this is open-source, feel free to implement these features on your own.
#### Can you add ... to the game?
No. First of all, we are no game developers and don't have the capabilities to add features like completely new weapons or the testing area. Second of all, we are using the official Steam version of Uberstrike and have no control about it's features at all, because it's already compiled and you cannot edit Unity-based games once complied.
#### Why is everything free? / Why does every armor has the same AP?
We started this project because we missed the fun we had when playing Uberstrike and we'll stick to this plan. Our goal is to create a fair economy system, enabling everyone to pick the weapon he wants (rather than the weapon he can purchase) and to pick the armor he likes the most, without the need to be worried about his chances. If you don't like our attitude, feel free to change the respective values on your own.
#### Is this *really* no fake?
Trust us, if we would troll you with this, we would also troll ourselves.
