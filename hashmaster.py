import hashlib
import hmac
print("============================================================")
print("Created by: Corvus Codex")
print("Github: https://github.com/CorvusCodex/")
print("Licence : MIT License")
print("Support my work:")
print("BTC: bc1q7wth254atug2p4v9j3krk9kauc0ehys2u8tgg3")
print("ETH & BNB: 0x68B6D33Ad1A3e0aFaDA60d6ADf8594601BE492F0")
print("Buy me a coffee: https://www.buymeacoffee.com/CorvusCodex")
print("============================================================")


input_string = input("Enter input string: ")
print("============================================================")
key = input("Enter secret key: ").encode()
print("============================================================")


# Compute HMAC-SHA-256 hash
sha256_hash = hmac.new(key, input_string.encode(), hashlib.sha256).hexdigest()
# print(f"HMAC-SHA-256: {sha256_hash}")

# Compute HMAC-SHA-512 hash
sha512_hash = hmac.new(key, input_string.encode(), hashlib.sha512).hexdigest()
# print(f"HMAC-SHA-512: {sha512_hash}")

# Compute HMAC-SHA-384 hash
sha384_hash = hmac.new(key, input_string.encode(), hashlib.sha384).hexdigest()
# print(f"HMAC-SHA-384: {sha384_hash}")

# Compute HMAC-SHA-224 hash
sha224_hash = hmac.new(key, input_string.encode(), hashlib.sha224).hexdigest()
# print(f"HMAC-SHA-224: {sha224_hash}")

# Concatenate the results
concatenated_hashes = sha256_hash + sha512_hash + sha384_hash + sha224_hash
print(f"Concatenated hashes: {concatenated_hashes}")
