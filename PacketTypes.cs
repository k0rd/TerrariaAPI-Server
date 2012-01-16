using System;
public enum PacketTypes
{
	ConnectRequest = 1,
	Disconnect,
	ContinueConnecting,
	PlayerInfo,
	PlayerSlot,
	ContinueConnecting2,
	WorldInfo,
	TileGetSection,
	Status,
	TileSendSection,
	TileFrameSection,
	PlayerSpawn,
	PlayerUpdate,
	PlayerActive,
	SyncPlayers,
	PlayerHp,
	Tile,
	TimeSet,
	DoorUse,
	TileSendSquare,
	ItemDrop,
	ItemOwner,
	NpcUpdate,
	NpcItemStrike,
	ChatText,
	PlayerDamage,
	ProjectileNew,
	NpcStrike,
	ProjectileDestroy,
	TogglePvp,
	ChestGetContents,
	ChestItem,
	ChestOpen,
	TileKill,
	EffectHeal,
	Zones,
	PasswordRequired,
	PasswordSend,
	ItemUnknown,
	NpcTalk,
	PlayerAnimation,
	PlayerMana,
	EffectMana,
	PlayerKillMe,
	PlayerTeam,
	SignRead,
	SignNew,
	LiquidSet,
	PlayerSpawnSelf,
	PlayerBuff,
	NpcSpecial,
	ChestUnlock,
	NpcAddBuff,
	NpcUpdateBuff,
	PlayerAddBuff,
	UpdateNPCName,
	UpdateGoodEvil,
	PlayHarp,
	HitSwitch,
    UpdateNPCHome,
    SpawnBossorInvasion
}
