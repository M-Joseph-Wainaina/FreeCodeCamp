import asyncio

async def helloInSwahili():
    
    print("Sasa")

async def helloInEnglish():
    
    print("Hello!!!")

async def main():
    await helloInEnglish()
    await helloInSwahili()

asyncio.run(main())