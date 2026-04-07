
# Charleroi XR — Art on Unity

> Permettons aux artistes du groupe de voir leurs assets dans les casques sans étudier la XR sur Unity3D.

Dans ce répertoire, déposez des assets 3D que vous souhaiteriez voir en VR sur le Quest 3.
Ensuite, demandez au développeur délégué, ou au tech artist, de builder le projet 😉

**Projet :**
[https://github.com/EloiStree/2026_04_07_unity_charleroi_xr_art](https://github.com/EloiStree/2026_04_07_unity_charleroi_xr_art)

Pour y ajouter vos assets, suivez le tutoriel ici :
[https://github.com/EloiStree/2026_04_07_workshop_hello_art_and_git/blob/main/day_2/ReadMe.md](https://github.com/EloiStree/2026_04_07_workshop_hello_art_and_git/blob/main/day_2/ReadMe.md)

---

## Ajouter la boîte à outils à votre projet

Je préfère :
```
git clone https://github.com/EloiStree/2026_04_07_upm_charleroi_xr_art_on_unity.git Packages/2026_04_07_upm_charleroi_xr_art_on_unity
```

Selon Unity :
```
git clone https://github.com/EloiStree/2026_04_07_upm_charleroi_xr_art_on_unity.git Packages/be.techno.charleroixrart
```

Si vous clonez dans un projet Git déjà établi :
```
git submodule add https://github.com/EloiStree/2026_04_07_upm_charleroi_xr_art_on_unity.git Packages/2026_04_07_upm_charleroi_xr_art_on_unity
```

Avec le Package Manager en lecture seule :
`https://github.com/EloiStree/2026_04_07_upm_charleroi_xr_art_on_unity.git`

Avec le `Manifest.json` en lecture seule:

```
  "be.techno.charleroixrart":"https://github.com/EloiStree/2026_04_07_upm_charleroi_xr_art_on_unity.git"
```




